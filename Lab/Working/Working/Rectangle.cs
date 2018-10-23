namespace Working_with_Abstraction
{
    public class Rectangle
    {
        public Point TopLeftPoint
        {
            get; set;
        }

        public Point LowerRightPoint
        {
            get; set;
        }

        public Rectangle(Point topLeftPoint, Point lowerRightPoint)
        {
            TopLeftPoint = topLeftPoint;
            LowerRightPoint = lowerRightPoint;
        }

        public bool Contains(Point point)
        {
            var isInside = TopLeftPoint.PointX <= point.PointX
                       && LowerRightPoint.PointX >= point.PointX
                       && TopLeftPoint.PointY <= point.PointY
                       && LowerRightPoint.PointY >= point.PointY;
            return isInside;
        }
    }
}