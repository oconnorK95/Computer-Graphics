using UnityEngine;

public class Outcode
{
    float x;
    float y;
    internal bool up, down, left, right;
  

    // Start is called before the first frame update

    public Outcode() { 
    }

   
    public Outcode(Vector2 point) {
        //if (point.y > 1) up = true; else up = false;
        up = (point.y > 1);
        down = (point.y) < 1;
        left = (point.x) < 1;
        right = (point.x) > 1;
         
    }

    public override string ToString() {
        string output = "";
        if (up) output += "1"; else output += "0";
        if (down) output += "1"; else output += "0";
        if (left) output += "1"; else output += "0";
        if (right) output += "1"; else output += "0";
        return output;
    }

    public Outcode(Outcode outcode_to_clone)
    {
        up = outcode_to_clone.up;
        down = outcode_to_clone.down;
        left = outcode_to_clone.left;
        right = outcode_to_clone.right;
    }

    public Outcode(bool up, bool down, bool left, bool right)
    {
        this.up = up;
        this.down = down;
        this.left = left;
        this.right = right;
    }

    public static Outcode operator +(Outcode a, Outcode b) {// Implement logical or
        //if up down left or right, reject?
        return new Outcode((a.up || b.up), (a.down || b.down), (a.left || b.left), (a.right || b.right));

    }

    public static Outcode operator *(Outcode a, Outcode b) {
        //implement logical and multiply
        return new Outcode((a.up && b.up), (a.down && b.down), (a.left && b.left), (a.right && b.right));
    }

    public static bool operator ==(Outcode a, Outcode b)
    {
        return (a.up == b.up) && (a.down == b.down) && (a.left == b.left) && (a.right == b.right);

        //implement logical equals return bool
    }
    public static bool operator !=(Outcode a, Outcode b)
    {
        return !(a == b);
        //implement logical not equals return bool
    }


    public void print() { //as 0000
    
    }
}
