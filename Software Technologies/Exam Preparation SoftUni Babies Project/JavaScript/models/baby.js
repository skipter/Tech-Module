const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    // TODO FIXME

    let Baby = sequelize.define('Baby', {
        name:{type: Sequelize.STRING, required: true, allowNull: false,},
        gender:{type: Sequelize.STRING, required: true, allowNull: false,},
        birthday:{type: Sequelize.STRING, required: true, allowNull: false,}
    }, {
        timestamp:false
    });

    return Baby;
};