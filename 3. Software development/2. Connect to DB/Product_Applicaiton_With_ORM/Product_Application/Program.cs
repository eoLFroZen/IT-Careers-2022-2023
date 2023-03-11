// See https://aka.ms/new-console-template for more information
using Product_Application.Business;
using Product_Application.Presentation;

ProductBusiness productBusiness = new ProductBusiness();

Display display = new Display(productBusiness);

display.PrintAllCommands();