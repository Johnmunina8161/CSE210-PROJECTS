/*
              +----------------+
              |    Activity    |
              +----------------+
              | -minutes: int  |
              +----------------+
              | +Minutes       |
              | +GetDistance() |
              | +GetSpeed()    |
              | +GetPace()     |
              | +GetSummary()  |
              +-------^--------+
                      ^
                      |
                      |            +---------------------+
                      |            |   RunningActivity   |
                      |            +---------------------+
                      |            | -distance: double  |
                      |            +---------------------+
                      |            | +Distance          |
                      |            | +GetDistance()     |
                      |            | +GetSpeed()        |
                      |            | +GetPace()         |
                      |            | +GetSummary()      |
                      |            +---------------------+
                      |
                      |            +---------------------+
                      |            |   CyclingActivity   |
                      |            +---------------------+
                      |            | -distance: double  |
                      |            +---------------------+
                      |            | +Distance          |
                      |            | +GetDistance()     |
                      |            | +GetSpeed()        |
                      |            | +GetPace()         |
                      |            | +GetSummary()      |
                      |            +---------------------+
                      |
                      |            +---------------------+
                      |            |  SwimmingActivity   |
                      |            +---------------------+
                      |            | -laps: int         |
                      |            +---------------------+
                      |            | +Laps              |
                      |            | +GetDistance()     |
                      |            | +GetSpeed()        |
                      |            | +GetPace()         |
                      |            | +GetSummary()      |
                      |            +---------------------+
                      |
                      |
              +-------+-------+
              |    Program     |
              +-------^-------+
                      |
                      |
                  +---+---+
                  |       |
                  v       v
   +------------------+  +-----------------+
   | RunningActivity  |  | CyclingActivity |
   +------------------+  +-----------------+
   |                  |  |                 |
   +------------------+  +-----------------+
                        |
                        |
              +---------+----------+
              | SwimmingActivity   |
              +--------------------+
              |                    |
              +--------------------+

*/