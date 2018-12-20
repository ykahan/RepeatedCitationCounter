"# RepeatedCitationCounter"

This app allows the user to select any given masechta of the Talmud (assuming that I've loaded the text and enabled the option in a combo box) and scan it, looking for places where the same line of Mishna is cited twice in succession.  It depends upon sorting citations from Gemara proper on the basis of length.  That is, it assumes that citations have n or fewer characters, and that blocks of Gemara proper have more than n characters. It allows the user to select the value of n by means of a numeric-up-down control.  The control is built to allow for 1 <= n <= 300, permitting maximum user flexibility.

Whenever the user alters the value of n or the targeted masechta, a text message appears on the app screen, confirming the change.

When the user presses the "Analyze" button, the app performs the requisite analysis and displays a text message of the form "Masechta x has n repeated citations."  If the "Save To Text File" checkbox is checked, then the analysis is saved in a generated text file.  At present the path is hard-coded in, and the file name is generated based on the test done.  Later I plan to upgrade the functionality to allow the user to designate the file path and name.

The "Print Blocks" and "Short Blocks" buttons are meant for debugging purposes, and will be removed in a later iteration. In the meanwhile, it displays the targeted text in a text window to the side of the app screen, arranged in the form of a string array.  All spaces and episodes of "etc" have been removed from the strings in the array.
