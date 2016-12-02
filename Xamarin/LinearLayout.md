# Codigo de como trabajar los linearLayout en Xamarin
### Tutorial v.10 www.ymatias.com
  
 Les compartiré el código fuente como trabajar el linearLayout en Xamarin Android
 el Codigo de Ejemplo pertenece al ActivityMain.axml

## Ejemplo de codigo

```xml

<?xml version="1.0" encoding="utf-8"?>
<LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
    android:orientation="vertical"
    android:layout_width="fill_parent"
    android:layout_height="fill_parent">

    <EditText
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/password"
        android:padding="10dp"
        android:hint="@string/username_hint" />
    
    <EditText
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:id="@+id/password"
        android:padding="10dp"
        android:hint="@string/password_hint" />
    <Button
        android:id="@+id/submit"
        android:layout_width="200dp"
        android:layout_height="wrap_content"
        android:padding="10dp"
        android:text="@string/login" />
    <Button
        android:id="@+id/register"
        android:layout_width="200dp "
        android:layout_height="wrap_content"
        android:padding="10dp"
        android:text="@string/register" />
</LinearLayout>



```