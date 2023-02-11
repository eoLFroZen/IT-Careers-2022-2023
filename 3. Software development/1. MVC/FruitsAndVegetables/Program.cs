using FruitsAndVegetables.Controller;
using FruitsAndVegetables.Service;
using FruitsAndVegetables.View;

var display = new Display();
var harvestService = new HarvestService();
var exchangeService =new ExchangeService();
var harvestController = new HarvestController(display, harvestService, exchangeService);

harvestController.CalculateHarvestProfit();