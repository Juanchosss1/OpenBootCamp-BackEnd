
using System.Collections;
using System.Drawing;

var coloursCollection = new MyColours();
foreach (Color colour in coloursCollection)
{
    Console.WriteLine($"Colour: {colour.Name}\tHexadecimal Code: {colour.HexCode}");
}

public class MyColours : System.Collections.IEnumerable
{
    private Color[] _colours = {
    new Color(){ Name = "Red", HexCode="CB3234" },
    new Color(){ Name = "Blue", HexCode="0000FF" },
    new Color(){ Name = "Green", HexCode="008F39" }
    };

    public IEnumerator GetEnumerator()
    {
        return new ColoursEnumerator(_colours);
    }

    private class ColoursEnumerator : IEnumerator
    {
       private Color[] _colours;
        private int _position = -1;

       public ColoursEnumerator(Color[] colours)
        {
            _colours = colours;
        }

        object IEnumerator.Current { get { return _colours[_position]; } }

        public bool MoveNext()
        {
           _position++;
            return (_position < _colours.Length);
        }

        public void Reset()
        {
           _position = -1;
        }
    }
}

public class Color
{
    public string Name { get; set; }
    public string HexCode { get; set; }
}