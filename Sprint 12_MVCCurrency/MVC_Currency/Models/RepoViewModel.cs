namespace MVC_Currency
{
    public class RepoViewModel
    {
        ICurrencyRepo repo;

        public RepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
        }

        public double TotalValue
        {
            get { return repo.TotalValue(); }
        }

        public void MakeChange(Double Amount)
        {
            repo = repo.MakeChange(Amount);
        }

        public List<ICoin> Coins
        {
            get
            { return repo.Coins; }
        }
    }
}
