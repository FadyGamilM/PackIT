# PackIT
Packing-It is an application that help users in their up coming journeys by proposing for them a list of important stuff to be packed by collecting some info from the user such as the location of the journey, the time, the gender of the user, ..etc. 

## This project is following the DDD and Clean-Architecture approach.
![](Clean%20Architecture.png)

## Domain Layer
- The domain of our business is all about the DDD Entities, the DDD Entities are objects with their identityies.
  
- To extract the domain entities i started by analyzing the business problem of my app, the app service will take inputs from the user and based on these input parameters it will recommend the sutible package for this travel, and these paramters are :
   
   - The gender of the user.
   - The destination of the travel.
   - The travel days.