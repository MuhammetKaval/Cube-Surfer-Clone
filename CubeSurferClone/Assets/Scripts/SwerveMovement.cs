using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
    private SwerveInputSystem _swerveInputSystem;
    [SerializeField] private float swerveSpeed = 0.5f;
    [SerializeField] private float maxSwerveAmount = 1f;

    // Yatay eksende hareket kýsýtlama
    [SerializeField] private float horizontalClamp = 4.5f;

    private void Awake()
    {
        _swerveInputSystem = GetComponent<SwerveInputSystem>();
    }

    private void Update()
    {
        float swerveAmount =Time.deltaTime * swerveSpeed * _swerveInputSystem.MoveFactoryX;

        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);

        transform.Translate(swerveAmount, 0, 0);

        // Yatay eksende hareketi kýsýtlama
        Vector3 clampedHorizontalPosition = transform.position;
        clampedHorizontalPosition.x = Mathf.Clamp(clampedHorizontalPosition.x, -horizontalClamp, horizontalClamp);
        transform.position = clampedHorizontalPosition;
    }
}
