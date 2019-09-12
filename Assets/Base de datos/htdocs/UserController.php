<?php
    include 'Database/Db.php';
    include 'Models/UserModel.php';

    if(isset($_POST['loginNickname']) && isset($_POST['loginPassword']))
    {
        $nickname = $_POST['loginNickname'];
        $password = $_POST['loginPassword'];

        $user = new User;
        $user-> setNickname($nickname);
        $user-> setPassword($password);
        $conseguirUsuario = $user->login();

        if($conseguirUsuario)
        {
            echo 'se logeo correctamente';
        }
        else
        {
            echo 'error';
        }
    }

    if(isset($_POST['registroEmail']) && isset($_POST['registroPassword']) && isset($_POST['registroNickname']))
    {
        $email = $_POST['registroEmail'];
        $nickname = $_POST['registroNickname'];
        $password = $_POST['registroPassword'];

        $user = new User;
        $user-> setEmail($email);
        $user-> setNickname($nickname);
        $user-> setPassword($password);
        $comprobarEmail = $user->existeEmail();
        $comprobarNickname = $user->existeNick();
        

        if($comprobarEmail)
        {
            echo 'email registrado';
        }
        else
        {
            if($comprobarNickname)
            {
                echo 'nickname registrado';
            }
            else
            {
                $registrarUsuario = $user->save();
                if($registrarUsuario)
                {
                    echo 'se registro correctamente';
                }
                else
                {
                    echo 'error en el registro';
                }   
            }
        }
        
    }

