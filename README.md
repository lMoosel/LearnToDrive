# LearnToDrive
Machine Learning like program

- Creates a large number of "Car" objects
- Each car is given it's distance to each wall, it's current rotation, and the current speed (along with weights)
- After crashing cars inherit the "best weights" with slight random alterations 
- Cars weights are recorded as the "best weights" if they achieve a new max distance
- Cars are occionsally given a random slight rotation to force them to corrent themselves
