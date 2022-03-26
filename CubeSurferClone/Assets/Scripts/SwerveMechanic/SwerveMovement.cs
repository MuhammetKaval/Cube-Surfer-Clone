using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float swerveSpeed = 0.5f;
    [SerializeField] private float maxSwerveAmount = 1f;

    // Yatay eksende hareket kisitlama
    [SerializeField] private float horizontalClamp = 2f;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void FixedUpdate()
    {
        float swerveAmount = Time.fixedDeltaTime * swerveSpeed * _swerveInputSystem.MoveFactoryX;

        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);

        transform.Translate(swerveAmount, 0, 0);

        // Yatay eksende hareketi kisitlama
        Vector3 clampedHorizontalPosition = transform.position;
        clampedHorizontalPosition.x = Mathf.Clamp(clampedHorizontalPosition.x, -horizontalClamp, horizontalClamp);
        transform.position = clampedHorizontalPosition;
    }
}

