using UnityEngine;

public class Obstacle : GameCharacter
{
    //variable list
    private int moveDirection = 1; // 1 for right, -1 for left

    // left and right movement limits

public float leftLimit = -5f;
public float rightLimit = 5f;
    
protected override void Update()
{
    //move function
}

void Start()
{
   characterName = "Obstacle"; // Set the character name for the obstacle

    Debug.Log("Obstacle created: " + characterName); // Log the creation of the obstacle
}
void moveObstacle()
{
    // Move the obstacle horizontally
    transform.Translate(Vector2.right * moveDirection * speed * Time.deltaTime);
    
    // Check if the obstacle has reached the left or right limit
    if (transform.position.x >= rightLimit)
    {
        moveDirection = -1; // Change direction to left
    }
    else if (transform.position.x <= leftLimit)
    {
        moveDirection = 1; // Change direction to right
    }
}
}