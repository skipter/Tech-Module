const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    //TODO: Implement me

    let Lab = sequelize.define('Lab', {
        name:{type: Sequelize.TEXT,required: true, allowNull: false,
        },
        capacity:{
            type: Sequelize.INTEGER,required: true, allowNull: false,
        },
        status:{
            type: Sequelize.TEXT,required: true, allowNull: false,
        }
    }, {
        timestamps:false
    });
    return Lab;
};