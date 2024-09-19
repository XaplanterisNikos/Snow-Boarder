using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 1f;
    void Start()
    {
        /// <summary>
        /// Ανακτά το στοιχείο (component) Rigidbody2D που είναι συνδεδεμένο με το τρέχον GameObject
        /// και το αποθηκεύει στη μεταβλητή rb2d για μελλοντική χρήση.
        /// </summary>
        /// <remarks>
        /// Το Rigidbody2D χρησιμοποιείται για τη φυσική κίνηση και αλληλεπίδραση του αντικειμένου
        /// στο 2D περιβάλλον, όπως η βαρύτητα, οι δυνάμεις και η ροπή.
        /// </remarks>
        /// <param name="rb2d">
        /// Μεταβλητή που αποθηκεύει το Rigidbody2D του αντικειμένου.
        /// </param>

        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        /// <summary>
        /// Ελέγχει αν το αριστερό βελάκι στο πληκτρολόγιο είναι πατημένο. 
        /// Αν είναι, προσθέτει ροπή στο αντικείμενο χρησιμοποιώντας το Rigidbody2D.
        /// </summary>
        /// <param name="KeyCode.LeftArrow">
        /// Το πλήκτρο που ελέγχεται, το αριστερό βελάκι.
        /// </param>
        /// <param name="rb2d">
        /// Το Rigidbody2D του αντικειμένου που δέχεται τη ροπή.
        /// </param>
        /// <param name="torqueAmount">
        /// Η ποσότητα ροπής που προστίθεται στο αντικείμενο όταν πατηθεί το πλήκτρο.
        /// </param>

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }


        /// <summary>
        /// Ελέγχει αν το αριστερό βελάκι στο πληκτρολόγιο είναι πατημένο. 
        /// Αν είναι, προσθέτει ροπή στο αντικείμενο χρησιμοποιώντας το Rigidbody2D.
        /// </summary>
        /// <param name="KeyCode.RightArrow">
        /// Το πλήκτρο που ελέγχεται, το δεξί βελάκι.
        /// </param>
        /// <param name="rb2d">
        /// Το Rigidbody2D του αντικειμένου που δέχεται τη ροπή.
        /// </param>
        /// <param name="-torqueAmount">
        /// Η ποσότητα ροπής που προστίθεται στο αντικείμενο όταν πατηθεί το πλήκτρο.
        /// </param>
        /// 
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
