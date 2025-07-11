# Solar Pitch Calculator

A simple **C# WinForms** application to calculate the **row-to-row pitch distance** for solar panel arrays based on panel height difference and minimum solar elevation angle.

---

## 📐 Formula
The pitch is calculated as:
pitch = (rear-to-front panel height difference) / tan(minimum solar elevation angle)

Where:
- `panel height difference` = the elevation difference between rear and front of the panel (meters).
- `minimum solar elevation angle` = lowest expected sun angle at your site (degrees).

---

## 🔧 Features
✅ Input rear-to-front panel height difference.  
✅ Input minimum solar elevation angle.  
✅ Outputs the required pitch distance, rounded to 4 decimal places.  
✅ Lightweight and easy-to-use WinForms interface.

---

## 🚀 How to Run
1️⃣ Open the solution (`PitchCalculator.sln`) in Visual Studio.  
2️⃣ Build and run the application.  
3️⃣ Enter the two input values and click **Calculate**.

---

## 📄 Example
Input:
- Panel Height Difference: `2.1`
- Minimum Solar Elevation Angle: `32`

Output:
- Pitch Distance: `3.3607`

---

## 📝 License
This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

---

## 📬 Contributions
Pull requests, suggestions and improvements are welcome!
