
namespace BCDaddition
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input 1
            Read readObj = new Read();
            string num1 = readObj.Input1();
            string num2 = string.Empty;

            Validations validationObj = new Validations();
            Write writeObj = new Write();

            bool readAllInputs = true;

            // Read user input 2 if input 1 is valied 
            // if input is invalid then return which input is invalid
            if (validationObj.CheckInput(num1))
            {
                num2 = readObj.Input2();
                if (!validationObj.CheckInput(num2))
                {
                    writeObj.InvalidInput2();
                    readAllInputs = false;
                }
            }
            else
            {
                writeObj.InvalidInput1();
                readAllInputs = false;
            }

            // Floating Addition logic is executed if both the inputs are valid
            if (readAllInputs)
            {
                Logic logicObj = new Logic();
                logicObj.FloatAdditionLogic(num1, num2);
            }
        }
    }
}
