namespace DataLayer
{
    /// <summary>
    /// This class is used to create DAL objects 
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// Used to send the DAL Authentication objects 
        /// </summary>
        /// <returns></returns>
        public IDAL DALObjCreation()
        {
            return new DALAuthentication();
        }
    }
}
