namespace DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cusstomers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Tel = c.String(),
                        Mobile = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderDescription = c.String(),
                        CustomerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Cusstomers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailsID = c.Int(nullable: false, identity: true),
                        FoodID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailsID)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.FoodID)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        UnitPrice = c.Int(nullable: false),
                        Ingredients = c.String(),
                        Description = c.String(),
                        CategoryID = c.Int(nullable: false),
                        FoodCategory_FoodCategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategory_FoodCategoryID)
                .Index(t => t.FoodCategory_FoodCategoryID);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        FoodCategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FoodCategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Cusstomers");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Foods", "FoodCategory_FoodCategoryID", "dbo.FoodCategories");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Foods", new[] { "FoodCategory_FoodCategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.OrderDetails", new[] { "FoodID" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Foods");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Employees");
            DropTable("dbo.Orders");
            DropTable("dbo.Cusstomers");
        }
    }
}
