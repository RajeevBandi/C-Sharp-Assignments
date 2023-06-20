namespace BusinessLayer
{
    /// <summary>
    /// This class is used to create BAL objects 
    /// </summary>
    public class BALFactory
    {
        /// <summary>
        /// Used to send the BAL Authentication objects 
        /// </summary>
        /// <returns></returns>
        public IBAL BALObjCreation()
        {
            return new BALAuthentication();
        }
    }
}
