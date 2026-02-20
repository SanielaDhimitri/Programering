namespace WebApplication2.Models
{
  
            public class Calculator
            {
                public double A { get; set; }
                public double B { get; set; }
                public string Operator { get; set; }
                public double Result { get; set; }

                public void Calculate()
                {
                    switch (Operator)
                    {
                        case "+":
                            Result = A + B;
                            break;
                        case "-":
                            Result = A - B;
                            break;
                        case "*":
                            Result = A * B;
                            break;
                        case "/":
                            Result = A / B;
                            break;
                    }
                }
            }
        }
       