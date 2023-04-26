
// angle per minute , minutes arrow 
double minute_step = 360 / 60;
// hour arrow angle per minute assuming it moves slightly with every minute passes by :
double hour_step = 360 / 12 ;
double hour_minute_step = (360.0 / 12.0 )/60.0;

Console.Write("enter time : ");
DateTime time = Convert.ToDateTime(Console.ReadLine());

double minute_angle = time.Minute * minute_step;
double hour_angle = (time.Hour % 12) * hour_step;// + hour_minute_step * time.Minute;

double lesser_angle = Math.Abs(minute_angle - hour_angle) < 180 ? Math.Abs(minute_angle - hour_angle) : 360 - Math.Abs(minute_angle - hour_angle ); 
Console.WriteLine("result: " + lesser_angle);