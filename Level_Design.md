<div dir="rtl">

# **Level Design**

להלן פירוט השלבים, אלמנטים משתנים והדרגתיות הקושי בהתקדמות בשלבים:

![Level Design Table](https://github.com/GameDev000/Sababich/blob/main/Screenshot%202025-11-17%20154700.png)

כחלק מהמשחק ועלייה ברמות יתווסף אלמנט טיגון שידרוש מהשחקן לשמור על פוקוס תוך כדי הרכבת המנות: 

<table>
<thead>
  <tr>
    <th>רכיב</th>
    <th>אופן שימוש</th>
    <th>רמה שבה מופיע לראשונה</th>
    <th>הערות</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td><strong>ביצה</strong></td>
    <td>טיגון מהיר</td>
    <td>Tutorial ומעלה</td>
    <td>עלולה להישרף ברמות קשות</td>
  </tr>
  <tr>
    <td><strong>חציל</strong></td>
    <td>טיגון בינוני</td>
    <td>רמה 1 ומעלה</td>
    <td>דורש המתנה/הפיכה</td>
  </tr>
  <tr>
    <td><strong>צ'יפס תפו"א/ בטטה</strong></td>
    <td>טיגון קצר</td>
    <td>רמה 3</td>
    <td>נדרש להימנע מבלבול בין 2 הסוגים ושריפה של המטוגנים</td>
  </tr>
</tbody>
</table>

</div>

<div dir="rtl" lang="he">
  <h2>שלב 0 – Tutorial (ישראל)</h2>
  <p>
    דוכן בסיסי מאוד: לקוח יחיד, ביצה קשה וטחינה בלבד, ללא טיגון וללא הסחות דעת.
    המטבעות וזמן השלב מופיעים בשורת UI בתחתית המסך.
  </p>
</div>

<div dir="ltr">
<pre>
+---------------------------------------+
|                 C1                    |
|           (single customer)           |
|---------------------------------------|
|             SERVE COUNTER             |
|---------------------------------------|
|   PITA           EGG       TAHINI     |
|                                       |
|               PREP AREA               |
+---------------------------------------+
| TIME:  ∞ (tutorial)    COINS: 000     |
+---------------------------------------+
</pre>
</div>

<div dir="rtl" lang="he">
  <p><strong>אגדה:</strong></p>
  <ul>
    <li>C1 – לקוח יחיד בתור</li>
    <li>SERVE COUNTER – דלפק הגשה והרכבת סביח</li>
    <li>PITA – פיתות</li>
    <li>EGG (hard) – ביצה קשה</li>
    <li>TAHINI – טחינה</li>
    <li>PREP AREA – אזור עבודה כללי</li>
    <li>שורת UI תחתונה:
      <ul>
        <li><strong>TIME</strong> – טיימר שלב</li>
        <li><strong>COINS</strong> – סך המטבעות שנצברו</li>
      </ul>
    </li>
  </ul>
  <hr>
</div>

<div dir="rtl" lang="he">
  <h2>שלב 1 – קל (ישראל)</h2>
  <p>
    עומס קל: עד 3 לקוחות, ביצה קשה, חציל וטחינה.  
    כאן בפעם הראשונה מופיע אלמנט הטיגון (חציל בלבד).  
    אין עדיין הסחות דעת כבדות, רק רעש רקע כללי.
  </p>
</div>

<div dir="ltr">
<pre>
+---------------------------------------+
|      C1         C2         C3         |
|    (cust)     (cust)     (cust)       |
|---------------------------------------|
|             SERVE COUNTER             |
|---------------------------------------|
|  PITA        EGG     EGGPL   TAHINI   |
|                                       |
|          FRY ZONE                     |
|          [FRY-EGGPL ONLY]             |
+---------------------------------------+
| TIME: 02:00 avg       COINS: 000      |
+---------------------------------------+
</pre>
</div>

<div dir="rtl" lang="he">
  <p><strong>אגדה:</strong></p>
  <ul>
    <li>C1–C3 – עד שלושה לקוחות בתור בנפרד.</li>
    <li>SERVE COUNTER – דלפק שבו מרכיבים את המנה ללקוח.</li>
    <li>PITA – פיתות.</li>
    <li>EGG – ביצים קשות מוכנות.</li>
    <li>EGGPL – חציל לפני טיגון.</li>
    <li>TAHINI – טחינה.</li>
    <li>FRY ZONE – מחבת אחת לחציל בלבד.</li>
    <li>שורת UI תחתונה:
      <ul>
        <li><strong>TIME: 02:00 avg</strong> – זמן ממוצע לשלב.</li>
        <li><strong>COINS</strong> – המטבעות שהשחקן צובר.</li>
      </ul>
    </li>
  </ul>
  <hr>
</div>

<div dir="rtl" lang="he">
  <h2>שלב 2 – בינוני (יפן)</h2>
  <p>
    יותר לקוחות (עד 5–6) רק 2 במקביל, מצטרף רכיב חדש – סויה.  
    טיגון חציל נמשך, ולראשונה נכנסות הסחות דעת ברורות: טלפון, מוזיקה, הודעות רקע – באזור צד ייעודי.
  </p>
</div>

<div dir="ltr">
<pre>
+-----------------------------------------------+
|   C1      C2      C3      C4      C5         |
|-----------------------------------------NOISE|
|             SERVE COUNTER               AREA  |
|-----------------------------------------TEL   |
| PITA    EGG    EGGPL    TAHINI  SOY     ♫    |
|                                             |
|           FRY ZONE (EGGPL ONLY)             |
+---------------------------------------------+
| TIME: 04:00 avg            COINS: 000       |
+---------------------------------------------+
</pre>
</div>

<div dir="rtl" lang="he">
  <p><strong>אגדה:</strong></p>
  <ul>
    <li>C1–C5 – עד חמישה לקוחות בתור.</li>
    <li>SERVE COUNTER – דלפק הגשה.</li>
    <li>PITA – פיתות.</li>
    <li>EGG – ביצים קשות.</li>
    <li>EGGPL – חציל לטיגון.</li>
    <li>TAHINI – טחינה.</li>
    <li>SOY – סויה.</li>
    <li>FRY ZONE – אזור טיגון חציל.</li>
    <li>NOISE AREA / TEL / ♫ – אזור הסחות הדעת:
      <ul>
        <li>צלצול טלפון</li>
        <li>מוזיקת רקע</li>
        <li>קריאות רקע</li>
      </ul>
    </li>
    <li>שורת UI תחתונה:
      <ul>
        <li><strong>TIME: 04:00 avg</strong></li>
        <li><strong>COINS</strong> – סכום המטבעות בשלב</li>
      </ul>
    </li>
  </ul>
  <hr>
</div>

<div dir="rtl" lang="he">
  <h2>שלב 3 – קשה (ארה"ב)</h2>
  <p>
    עומס גבוה: תור ארוך, כל הרכיבים במשחק פעילים (ביצה קשה, חציל, טחינה, סויה, צ'יפס תפו"א/בטטה).  
    הטיגון מורכב יותר – חציל וצ'יפס במקביל, אזור הסחות גדול ורועש, והמטבעות קריטיים לעבור את השלב.
  </p>
</div>
<div dir="rtl" lang="he">
<pre>
+---------------------------------------------------+
| C1   C2   C3   C4   C5   C6   C7   C8             |
|------------------------------------------------NOI|
|                 SERVE COUNTER                 SE  | 
|------------------------------------------------ CT|
| PITA    EGG    EGGPL    TAHINI  SOY   FRIES       |
|                                                   |
|    FRY ZONE A           |      FRY ZONE B         |
|    [EGGPL]              |   [FRIES POT/BAT]       |
+-------------------------------------------------+
| TIME: 04:00 avg      COINS: 000   TARGET: 300-350 |
+-------------------------------------------------+
</pre>
</div>

<div dir="rtl" lang="he">
  <p><strong>אגדה:</strong></p>
  <ul>
    <li>C1–C8 – עד שמונה לקוחות בתור.</li>
    <li>SERVE COUNTER – דלפק הכנה.</li>
    <li>PITA – פיתות.</li>
    <li>EGG – ביצה קשה.</li>
    <li>EGGPL – חציל.</li>
    <li>TAHINI – טחינה.</li>
    <li>SOY – סויה.</li>
    <li>FRIES – צ'יפס.</li>
    <li>FRY ZONE A – טיגון לחציל.</li>
    <li>FRY ZONE B – טיגון צ'יפס.</li>
    <li>NOISE AREA – אזור הסחות (צעקות, מוזיקה חזקה).</li>
    <li>שורת UI תחתונה:
      <ul>
        <li><strong>TIME: 04:00 avg</strong></li>
        <li><strong>COINS</strong></li>
        <li><strong>TARGET: 300–350</strong></li>
      </ul>
    </li>
  </ul>
</div>
