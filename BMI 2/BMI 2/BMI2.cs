namespace BMI_2
{
    // Klassen BMI2 indeholder alt, hvad der skal til for at beregne BMI
    internal class BMI2
    {
        // Properties (offentlige felter med get/set)
        // Weight i kg, Height i meter
        public double Weight { get; set; }
        public double Height { get; set; }


        // Instansmetode
        // Beregner BMI ud fra instansens Weight og Height
        public double CalcBMI()
        {
            return Weight / (Height * Height);
        }

        // Statisk metode
        // Beregner BMI uden at oprette en instans
        // Input: weight (kg), height (meter)
        public static double CalcBMI(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
