<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;

class UserController extends Controller
{
    /**
     * @Route("register")
     * @return \Symfony\Component\HttpFoundation\Response
     */

    public function registerAction($name)
    {
        return $this->render('', array('name'));
    }
}
