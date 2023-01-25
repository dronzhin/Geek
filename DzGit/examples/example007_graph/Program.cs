Console.Clear();

int xa = 1, ya = 20,
    xb = 40, yb = 1,
    xc = 80, yc = 20;
int x = xa, y = ya;
int count = 0;
while (count < 10000){
    int what = new Random().Next(0,3);
    if (what == 0){
        x = (x + xa)/2;
        y = (y + ya)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+"); 
    }
    if (what == 1){
        x = (x + xb)/2;
        y = (y + yb)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+"); 
    }
    if (what == 2){
        x = (x + xc)/2;
        y = (y + yc)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+"); 
    }
    count++;
}


