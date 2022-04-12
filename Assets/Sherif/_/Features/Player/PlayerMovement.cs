using UnityEngine;

namespace PlayerMovementSettings
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Exposed

        [SerializeField] private float _speed = 10.0f;

        #endregion

        #region Private

        private Rigidbody _rigidbody;

        private Vector3 _movementInput;
        private Vector3 _orientationInput;

        #endregion

        #region Unity API

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Movement();
            Rotation();
        }

        private void FixedUpdate()
        {
            Vector3 velocity = _movementInput * _speed;
            _rigidbody.velocity = velocity;

            if (_orientationInput.sqrMagnitude != 0)
            {
                Quaternion lookRotation = Quaternion.LookRotation(_orientationInput);
                _rigidbody.MoveRotation(lookRotation);
            }
        }

        #endregion

        #region Main

        private void Movement()
        {
            float vertical = Input.GetAxisRaw("Vertical");
            float horizontal = Input.GetAxisRaw("Horizontal");

            _movementInput = new Vector3(horizontal, 0.0f, vertical).normalized;
        }

        private void Rotation()
        {
            float orientationVertical = Input.GetAxisRaw("Joystick Vertical");
            float orientationHorizontal = Input.GetAxisRaw("Joystick Horizontal");

            _orientationInput = new Vector3(orientationHorizontal, 0.0f, orientationVertical).normalized;
        }

        #endregion

        #region Utils

        #endregion

        #region Debug & Tools

        #endregion

    }
}
