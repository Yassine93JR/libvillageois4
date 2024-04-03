namespace libvillageois
{
    public class Potion
    {
        private int _dose;
        private int poids;

        public Potion(int _dose)

        {
            this._dose = _dose;
        }

        public void ajouterDose(int nb_doses)
        {
            _dose += nb_doses;
        }
        public int getDose()
        {
            return _dose;
        }
        public double ConséquencesDoses()
        {
            double min;
            if (_dose > 5 && _dose != 5)
            {
                min = 0.5;
            }
            else
            {
                min = 0.10;
            }
              return min;
        }
    }
}