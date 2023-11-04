# QR-Code-Generator-And-Decoder
This is a simple QR code generator and decoder tool that allows you to create QR codes from input strings of up to 122 characters. You can customize the foreground and background colors of the QR code. Additionally, it provides the option to save the generated QR code in various formats, including PNG, JPEG, BMP, and GIF.

# Features

**Generate QR Codes:** Input a string (up to 122 characters) and create a QR code from it.

**Color Customization:** Customize the foreground and background colors of the QR code to suit your preferences.

**Multiple Output Formats:** Save the generated QR code in different formats, such as PNG, JPEG, BMP, and GIF.

**QR Decoder:** Input a QR image and it will output the plain text.

# Screenshots

![Main Page](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/0269d971-3d14-4374-b073-d315b0ae9cf2)

![QR Code Generator](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/b2f30f81-f1e5-4c56-9922-1cab963fee8e)

![QR Code Decoder](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/e4acc5bb-1928-4377-b180-a68497e52b04)

# Usage Examples

### Example 1: Generating a Basic QR Code
Input String: "Hello, World!"

Foreground Color: Black

Background Color: White

Output Format: PNG

![QR Code Example](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/c4944603-1f73-4b46-8034-7df375987709)

### Example 2: Customizing QR Code Colors

Input String: "QR Code with Custom Colors"

Foreground Color: Red

Background Color: Yellow

Output Format: JPEG

![QR Code Example](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/8953669d-5fb5-43dc-a741-e7c4d19ed1a0)

### Example 3: Decoding Basic QR Code
![Decoding Basic QR Code Photo](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/325e18a8-f532-457f-9ff0-34217ab1eabc)

### Example 4: Decoding Customizing QR Code Colors
![Decoding Colour QR Code Photo](https://github.com/j0taylor6/QR-Code-Generator-And-Decoder/assets/149825449/8edd813f-f248-4ccf-bb35-365aa1800b6e)

# QR Generation Test Cases
1. Basic String Content: **PASS**
    - Test encoding of a simple URL, e.g., **`https://www.example.com`**.
    - Test encoding a plain text message, e.g., "Hello, world!"
2. **Character Set Support**: **PASS**
    - Include alphabetic characters, both lowercase and uppercase.
    - Include numeric characters.
    - Include special characters, such as **`! @ # $ % ^ & * ( ) - _ = +`**.
3. **Extended ASCII and Unicode**: **FAIL - Cannot use extended ASCII**
    - Generate QR codes with extended ASCII characters.
    - Generate QR codes with Unicode characters, including emojis, non-Latin scripts like Cyrillic, Chinese, Arabic, etc.
4. **Long Text Strings**: **PASS - Can do text up to 122**
    - Generate a QR code with a text string near the maximum capacity of a QR code (which varies depending on the version and error correction level).
5. **Encoding Binary Data**: **PASS - Utilized Base64 Encoding** 
    - Test if your generator can encode binary data, such as a small image or file, into a QR code.

# QR Decoder Test Cases


1. **Basic Decoding**: **PASS**
    - Decode a QR code with a simple URL or text message.
    - Decode a QR code with maximum capacity data.
2. **Special Characters and Encoding**: **PASS**
    - Decode QR codes that contain special characters and validate the output.
    - Decode QR codes with Unicode characters and ensure correct interpretation.
3. **Error Correction Resilience**: **PASS**
    - Test decoding QR codes that have been partially obscured or damaged to assess error correction performance.
4. **Cross-Version and Size Compatibility**: **PASS**
    - Decode QR codes of various sizes and versions to ensure compatibility.
5. **Color and Contrast**: **PASS**
    - Decode colored QR codes and QR codes with various contrast levels between the foreground and background.
6. **Different Image Formats**: **PASS**
    - Test decoding QR codes from different image file formats (JPG, PNG, BMP, GIF, etc.).
7. **Distorted Images**: **FAIL**
    - Test decoding QR codes from images that have been distorted (stretched, skewed, rotated) to test the robustness of the decoding algorithm.
  
## Licensing

This QR Code Generator and Decoder is distributed under the terms of the [MIT License](LICENSE). 

### MIT License

Copyright (c) [2023] [Joshua Taylor]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS," WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE, AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
