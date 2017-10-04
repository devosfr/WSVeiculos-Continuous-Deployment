<?php

if (strcasecmp('formulario-ajax', $_POST['metodo'] == 0)) {
	
    $html = 'Nome: '.$_POST['nome'];
    $html. = '\n';
    $html .= 'Nome: '.$_POST['nome'];

    echo $html;

}

?>