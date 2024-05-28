namespace GeometrieFlächeninhaltSortieren
{
    public class CShape : IComparable<CShape>
    {
        public int Surface { get; set; }

        public CShape(int surface)
        {
            Surface = surface;
        }

        
        public int CompareTo(CShape other)
        {
            if (other == null) return 1;

            
            return this.Surface.CompareTo(other.Surface);
        }
    }
    
    namespace GeometrieFlächeninhaltSortieren
    {
        public class CRectangel : CShape
        {
            public CRectangel(int surface) : base(surface)
            {
            }
        }
    }
    
    namespace GeometrieFlächeninhaltSortieren
    {
        public class CCircle : CShape
        {
            public CCircle(int surface) : base(surface)
            {
            }
        }
    }


}