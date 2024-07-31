namespace Teste
{
    public class Enumerator
    {
        
    }

    public enum EMaritalStatus
    {
        single = 1,
        married = 2,
        divorced = 3
    }

    public struct Client
    {
        public Client(string name, EMaritalStatus maritalStatus)
        {
            Name = name;
            MaritalStatus = maritalStatus;
        }
        public string Name;
        public EMaritalStatus MaritalStatus;
    }

    public enum ECompany
    {
        mastrerCompany = 1,
        trueCompany = 2,
        appCompany = 3
    }

    public enum EkindWork
    {
        developer = 1,
        design = 2,
        uxui = 3,
        devops = 4,
        engineer = 5
    }


    public struct PositionInCompany
    {   
        public PositionInCompany(ECompany company, EkindWork work)
        {
            Company = company;
            Work = work;
        }
        public ECompany Company;
        public EkindWork Work;
    }
}