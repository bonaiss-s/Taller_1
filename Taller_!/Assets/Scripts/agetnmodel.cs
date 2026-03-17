using UnityEngine;
using UnityEngine.InputSystem;
public class agentmodel : MonoBehaviour
{

    [SerializeField] private AgentController _Controlls;
    [SerializeField] private float _velocidad = 20f;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private AgentView _agentView;
    public void Movimiento()
    {

        _rb.linearVelocity = new Vector3(_Controlls.movevalue.y,
            _rb.linearVelocity.y, _Controlls.movevalue.x);


    }
    private void Update()
    {



        float veloMax = 10;
        float veloNormalizada = _rb.angularVelocity.magnitude / veloMax;

        if (_rb.linearVelocity.magnitude < 0.001)
        {
            veloNormalizada = 0.001f;
            _agentView.animator.SetFloat("velocidad", veloNormalizada);

        }

        else
        {
            _agentView.animator.SetFloat("Velocidad", _rb.linearVelocity.magnitude);
            Movimiento();
        }
    }
}


