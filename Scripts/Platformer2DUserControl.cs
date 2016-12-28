using UnityEngine;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;
        public int score;
        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if(!jump)
            // Read the jump input in Update so button presses aren't missed.
            jump = CrossPlatformInputManager.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            character.Move(h, crouch, jump);
            jump = false;
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if ((col.gameObject.name == "dieCollider") || (col.gameObject.name == "water") || (col.gameObject.name == "mina"))
                Application.LoadLevel(Application.loadedLevel);

            if (col.gameObject.name == "bonus")
            {
                score++;
                Destroy(col.gameObject);
            }

            if (col.gameObject.name == "flag")
            {
                Application.LoadLevel("scene2");
            }
            if (col.gameObject.name == "flag1")
            {
                Application.LoadLevel("scene3");
            }
        }




    }


}