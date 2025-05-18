using UnityEngine;

public class PlayerMovement : Movement
{
    [SerializeField] GameObject bala;
    [SerializeField] GameObject puntodisparo;
    [SerializeField] float velocidadbala;
    protected override void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        Vector3 velocity = direction * speed + new Vector3(0, rb.linearVelocity.y, 0);

        rb.linearVelocity = velocity;

        if (direction.magnitude > 0)
        {
            transform.forward = direction;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Disparo();
        }
    }
    void Disparo()
    {
        GameObject balatemporal = Instantiate(bala, puntodisparo.transform.position, puntodisparo.transform.rotation);
        balatemporal.GetComponent<Rigidbody>().linearVelocity = puntodisparo.transform.forward * velocidadbala;
    }
}
