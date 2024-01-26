// See https://aka.ms/new-console-template for more information
using FlyWeightEx;

DiscountCalculate discount = new DiscountCalculate();
var cal = discount.GetDiscountCalc("day");
var value = cal.GetDiscount(DateTime.Now);
Console.WriteLine(value);