namespace Day02
{
    internal class GameInfo
    {
        internal int Id { get; set; }

        private int _maxGreen;
        internal int MaxGreen
        {
            get => _maxGreen;
            set
            {
                if (value > _maxGreen)
                {
                    _maxGreen = value;
                }
            }
        }

        private int _maxBlue;
        internal int MaxBlue
        {
            get => _maxBlue;
            set
            {
                if (value > _maxBlue)
                {
                    _maxBlue = value;
                }
            }
        }

        private int _maxRed;
        internal int MaxRed
        {
            get => _maxRed;
            set
            {
                if (value > _maxRed)
                {
                    _maxRed = value;
                }
            }
        }
    }
}
