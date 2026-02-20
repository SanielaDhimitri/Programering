namespace CalcBmi
{
    public class BMI
    {
        // Properties
        public double Weight { get; set; }  // kg
        public double Height { get; set; }  // meter

        // Default constructor
        public BMI()
        {
            Weight = 80.0;
            Height = 1.80;  // meter (ikke cm)
        }

        // Instansmetode
        // Beregner BMI for denne instans
        public double CalcBMI()
        {
            return Weight / (Height * Height);
        }

    
    }
}