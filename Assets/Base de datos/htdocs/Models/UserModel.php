<?php
    //class User extends Database
    class User extends Database
    {
        private $id;
        private $email;
        private $password;
        private $nickname;

        //Getters
        function getId()
        {
            return $this->id;
        }
        function getEmail()
        {
            return $this->email;
        }
        function getPassword()
        {
            return password_hash($this->connect()->real_escape_string($this->password), PASSWORD_BCRYPT, ['cost'=>4]);
        }
        function getNickname()
        {
            return $this->nickname;
        }

        //Setters
        function setId($id)
        {
            $this->id = $id;
        }
        function setEmail($email)
        {
            $this->email = $this->connect()->real_escape_string($email);
        }
        function setPassword($password)
        {
            $this->password = $password;
        }
        function setNickname($nickname)
        {
            $this->nickname = $this->connect()->real_escape_string($nickname);
        }

        //funciones públicas
        public function login()
        {
            $password = $this->password;

            $sql = "SELECT * FROM user WHERE nickname = '{$this->getNickname()}'";

            $login = $this->connect()->query($sql);
            if($login && $login->num_rows == 1)
            {
                $usuario = $login->fetch_object();
                $verifyPassword = password_verify($password, $usuario->password);
                if($verifyPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public function save()
        {
            $sql = "INSERT INTO user (email, nickname, password) VALUES ('{$this->getEmail()}', '{$this->getNickname()}', '{$this->getPassword()}')";
            $save = $this->connect()->query($sql);
            $result = false;

            if($save)
            {
                $result = true;
            }
            return $result;
        }

        public function existeEmail()
        {

            $sql = "SELECT * FROM user WHERE email = '{$this->getEmail()}'";
            //consulta a la base de datos con la query guardada
            $email = $this->connect()->query($sql);   
            return $email->num_rows > 0 ? true : false;

        }
        public function existeNick()
        {

            $sql = "SELECT * FROM user WHERE nickname = '{$this->getNickname()}'";
            //consulta a la base de datos con la query guardada
            $nick = $this->connect()->query($sql);
            return $nick->num_rows > 0 ? true : false; 
        }
    }