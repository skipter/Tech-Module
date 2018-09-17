<?php
namespace CalculatorBundle\Entity;

class Calculator
{
    public $leftOperand;
    /**
     * @var float
     */

    public $rightOperand;
    /**
     * @var float
     */

    public $operator;
    /**
     * @var string
     */

    public function getLeftOperand()
    {
        return $this->leftOperand;
    }

    /**
     * @param float $leftOperand
     */
    public function serLeftOperand($leftOperand)
    {
        $this->leftOperand = $leftOperand;
    }

    /**
     * @return float
     */
    public function getRightOperand()
    {
        return $this->rightOperand;
    }

    /**
     * @param float $rightOperand
     */
    public function serRightOperand($rightOperand)
    {
        $this->leftOperand = $rightOperand;
    }

    /**
     * @return string
     */
    public function getOperator()
    {
        return $this->operator;
    }

    /**
     * @param string $operator
     */
    public function setOperator($operator)
    {
        $this->operator = $operator;
    }
}