# Reilly_Zink_3401week2
Game Development 1 lesson


3401 Info Sheet - Week 2 (01/22/19)
- Use unity primitives to “grey box” (prototype) functionality without final art assets
- Planes and Quads are both flat (2D) primitives
- Quads are 1 unit long, well-suited for simple display of images or sprites
- Planes are 10 units long, have more geometry than quads, and are useful as floors or walls
- The navigation window can be opened through Window -> AI -> Navigation
- The navigation window lets you define NavMesh properties
- A NavMesh is used to define a traversable area for an agent
- Agents can be created via a Nav Mesh Agent component
- Every time a property of a NavMesh is changed, the mesh must be re-baked
- Multiple gameObjects can be used to define a NavMesh and any obstacles within it
- An agent can be given a destination by calling the SetDestination (Vector3 destination) function
- Property drawers can be used to organize a script component in the inspector
- Region declarations can be used to organize your code inside script files
- Declare a variable to be public to expose it in the inspector
- By default, variables are private
- Two forward slashes can be used to comment out a line of code
- Commented-out code will be ignored during script execution
- The delta time is the time in seconds since the previous frame was drawn
- This means that games running at different frame rates have different delta times
- Delta time can be used to normalize values across disparate frame rates
- You can access the delta time since the previous frame with Time.deltaTime
- A sprite renderer component can be used to display a sprite in the game
- The texture type of an imported image asset can be changed in the inspector
- Conditionals can be used to evaluate code only if specific conditions are met
- The “if” statement is a popular boolean conditional
- “If” statements are written as follows: if (condition) { code executed if true }
- An else statement can be added to the end of an if statement to create bi-directional conditionals
- A boolean (bool) is a data type that can be either true or false
- An int is a data type representing integers, AKA whole numbers (negative or positive)
- A float is a floating point number (contains a decimal, more precise than int)
- A string is a data type containing a sequence of alphanumeric characters
- String literals are defined inside “double quotes”
- Functions are executable blocks of code that can be called from different parts of a script
- Unity includes several “magic functions” that are called at specific predetermined points
- These include Start () and Awake ()
