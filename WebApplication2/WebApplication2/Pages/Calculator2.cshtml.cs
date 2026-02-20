//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using WebApplication2.Models;

//namespace WebApplication2.Pages
//{
   
//public class CalculatorModel : PageModel
//{
//    [BindProperty]
//    public double A { get; set; }

//    [BindProperty]
//    public double B { get; set; }

//    [BindProperty]
//    public string Operator { get; set; }

//    public double Result { get; set; }

//    public void OnPost()
//    {
//        Calculator calc = new Calculator();
//        calc.A = A;
//        calc.B = B;
//        calc.Operator = Operator;

//        calc.Calculate();

//        Result = calc.Result;
//    }
//}
