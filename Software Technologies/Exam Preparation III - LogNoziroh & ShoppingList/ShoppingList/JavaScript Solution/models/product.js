const Sequelize = require('sequelize');

module.exports = function(sequelize){

    let Product = sequelize.define('Product', {
        priority:{type: Sequelize.INTEGER, required: true, allowNull:false,},
        name:{type: Sequelize.TEXT, required: true, allowNUll:false, },
        quantity:{type: Sequelize.INTEGER, required: true, allowNull:false,},
        status:{type: Sequelize.TEXT, required: true, allowNull:false,}
    }, {
        timestamps:false
    });
    return Product;
};