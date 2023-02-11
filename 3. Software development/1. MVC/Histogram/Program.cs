using Histogram.Controller;
using Histogram.Services;
using Histogram.View;

var display = new Display();
var histogramService = new HistogramService();
var histogramController = new HistogramController(display, histogramService);

histogramController.CreateHistogram();