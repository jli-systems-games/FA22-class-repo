using TMPro;
using UnityEngine;

namespace Nickel.NickelBalanace.script
{
    public class TextManager : MonoBehaviour
    {
        public TMP_Text Instruction1;
        public TMP_Text Instruction2;

        public string textShown;
        // Start is called before the first frame update
        void Start()
        {
            Instruction1.text = " ";
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void OnTriggerEnter(Collider other)
        {
            Instruction1.text = textShown;
            Instruction2.text = textShown;
        }

        private void OnTriggerExit(Collider other)
        {
            Instruction1.text = " ";
            Instruction2.text = " ";
        }

    }
}

