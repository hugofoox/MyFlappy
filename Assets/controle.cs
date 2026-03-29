using UnityEngine;

public class controle : MonoBehaviour
{
    public sistema _sistema;
    public ControlPlayer _controlPlayer;

    public Rigidbody2D _rb;
    public float _forca = 100f;

    public float _aceleracao = 5f;

    private void OnEnable()
    {
        _controlPlayer.Enable();
    }
    private void OnDisable()
    {
        _controlPlayer.Disable();
    }

    private void Awake()
    {
        _controlPlayer = new ControlPlayer();
        _controlPlayer.Aviao.Jump.performed += contexto => Pulando();
    }


    void Start()
    {
        
    }

    void Update()
    {
        _aceleracao += Time.deltaTime * 0.1f;
        transform.Translate(_aceleracao * Time.deltaTime, 0, 0);
    }

    void Pulando()
    {
        _rb.AddForce(Vector2.up * _forca, ForceMode2D.Force);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Inimigo")
        {
            _sistema.SistemaPerdeu();
        }
    }

}
