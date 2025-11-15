using UnityEngine;

public class ProjectileShooter
{
    // чтобы этот класс знал откуда брать префаб нужно их передать в КОНСТРУКТОР

    public void Shoot()
    {
        Debug.Log("Shoot");
        // 1. Создается клон префаба снаряда (Projectile)
        // Object.Instantiate();
        // 2. У снаряда вызывается метод Launch, который задает ему ускорение в направлении выстрела

    }
}
