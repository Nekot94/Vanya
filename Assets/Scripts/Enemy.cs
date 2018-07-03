using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10; // общедоступная переменная скорости
    public float rotationSpeed = 500; // Cкорость вращения
    public float movingDistance = 8; // До какого растояния дойдет обьект по X
    public bool randomSpeed;
    public float maxSpeed = 16;
    

	void Start ()
    {
        if (randomSpeed)
        {
            speed = Random.Range(1, maxSpeed);
        }
	}
	
	void Update ()
    {
        // Если положение обьекта больше равен movingDistance поворачиваем
        if (transform.position.x >= movingDistance || transform.position.x <= -movingDistance) 
        {
            speed = -speed;
        } 

        //else
        //{
        //    Debug.Log("Я не поворачиваю");
        //}
        transform.Translate(speed * Time.deltaTime, 0, 0); // Передвигает объект
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0); // Вращает объект


    }
}
