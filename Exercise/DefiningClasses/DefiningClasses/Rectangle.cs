namespace DefiningClasses
{
    internal class Rectangle
    {
        private string _id;
        private double _width;
        private double _height;
        private double _positionX;
        private double _positionY;

        public Rectangle(string id, double width, double height, double positionX, double positionY)
        {
            _id = id;
            _width = width;
            _height = height;
            _positionX = positionX;
            _positionY = positionY;
        }

        public bool Intersects(Rectangle rectangle)
        {
            return rectangle._positionX + rectangle._width >= _positionX &&
                   rectangle._positionX <= _positionX + _width &&
                   rectangle._positionY >= _positionY - _height &&
                   rectangle._positionY - rectangle._height <= _positionY;
        }

        public string GetId()
        {
            return _id;
        }
    }
}