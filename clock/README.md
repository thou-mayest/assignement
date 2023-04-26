to get the angle between the two arrow we should first get the "step" or value at which the angle varies each minute for both the minutes arrow and the hour arrow:
### for minute arrow: 
```c#
// angle per minute , minutes arrow
double minute_step = 360 / 60;
```
### for hour arrow:
```c#
// hour arrow angle per minute assuming it moves slightly with every minute passes by :
double hour_step = 360 / 12 ;
```
**PS**: assuming the hour arrow moves only once in an hour, some clocks where the hour arrow also slowly moves by a small margin each minute , so taking that into account i might add the hour arrow step each minute which would be the angle it moves in an hour 360 / 12 then deviding by 60 min:
```c#
double hour_minute_step = (360.0 / 12.0 )/60.0;
```

we calculate now angle of each arrow :
```c#
double minute_angle = time.Minute * minute_step;

double hour_angle = (time.Hour % 12) * hour_step;
```
again depending on wether or not we want to take into account the small variation of hour arrow between hours the hour_angle variable would :
```c#
double hour_angle = (time.Hour % 12) * hour_step + hour_minute_step * time.Minute;
```
i commented that out for simplicity i wouldn't consider the hour arrow minute variation as it's half a degree by minute anyway.
### getting the lesser angle:
to so we get the difference between the two angles , i considered the absolute value of the difference so it won't matter which has the bigger value so i won't get a negative value that should be somthing like:
```c#
double lesser_angle = Math.Abs(minute_angle - hour_angle)
```
in this case we will have the angle , but this angle would not be the lesser angle as for example :
![[https://github.com/thou-mayest/assignement/blob/master/clock/clock_arrow_big_angle.png]]
to get the lesser angle i simply check if the angle is bigger than 180° if true i keep the value as is , if it's bigger than 180 i simply substract the angle value from 360 the result is the lesser angle so :
```c#
double lesser_angle = Math.Abs(minute_angle - hour_angle) < 180 ? Math.Abs(minute_angle - hour_angle) : 360 - Math.Abs(minute_angle - hour_angle );
```
