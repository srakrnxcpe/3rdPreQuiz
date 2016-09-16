using System;
class Regression{
	public static void Main(){
		int n = Int32.Parse(Console.ReadLine());
		string rawInput;
		string[] sPos = {"",""};
		double x,y;
		double sx=0, sy=0, sxs=0, sxy=0;
		for(int i=0;i<n;i++){
			rawInput = Console.ReadLine();
			sPos = rawInput.Split(' ');
			x = double.Parse(sPos[0]);
			y = double.Parse(sPos[1]);
			sx += x;
			sy += y;
			sxs += x*x;
			sxy += x*y;
		}
		double det = sx*sx-n*sxs;
		double m = (sx*sy-n*sxy)/det;
		double c = (sx*sxy-sxs*sy)/det;
		Console.WriteLine("{0} {1}",m,c);
	}
}
