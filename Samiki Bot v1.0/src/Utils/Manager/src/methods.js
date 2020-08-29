const database = require('firebase').database()

/** 
 * Fetch a data from the database by a reference
 * @param {String} reference Reference to the database
 * @param {any} [defaultValue=null] Set a default value if anything is saved in this reference
 * @returns {Promise<any>}
 * 
 * @example
 * Manager.methods.getData('users/connecteds', 0)
 * .then(console.log)
 */
const getData = async (reference, defaultValue = null) => (await database.ref(reference).once('value')).val() || defaultValue

/** 
 * Sets a data into the database by a reference
 * @param {String} reference Reference to the database
 * @param {any} value Value to be saved into database
 * @returns {Promise<any>}
 * 
 * @example
 * Manager.methods.setData('users/connecteds', connectedUsers + 1)
 */
const setData = (reference, value) => database.ref(reference).set(value)

/** 
 * Increment a data into an array from the database by a reference
 * @param {String} reference Reference to the database
 * @param {...any} values Values to increment in the database (this reference needs to point to an array)
 * @returns {Promise<any>}
 * 
 * @example
 * Manager.methods.pushData('users/<UserID>/messages', someMessage, anotherMessage)
 */
const pushData = (reference, ...values) => getData(reference, [])
    .then(oldValues => setData(reference, [...oldValues, ...values]))

/** 
 * Increment a data value from the database by a reference
 * @param {String} reference Reference to the database
 * @param {Number} [values=1] Amount to be incremented
 * @returns {Promise<Number>}
 * 
 * @example
 * Manager.methods.incremenetData('users/<UserID>/likes', 1)
 * .then(newAmount => console.log(`Now this user has ${newAmount} likes!`))
 */
const incrementDataValue = (reference, amount = 1) => getData(reference, 0)
    .then(oldNumber => {
        const newAmount = +oldNumber + amount
        setData(reference, newAmount)
        return newAmount
    })

/** 
* Decrement a data value from the database by a reference
* @param {String} reference Reference to the database
* @param {Number} [values=1] Amount to be incremented
* @returns {Promise<Number>}
* 
* @example
* Manager.methods.decremenetData('user/someID/likes', 1)
* .then(newAmount => console.log(`Now this user has ${newAmount} likes!`))
*/
const decrementDataValue = (reference, amount = 1) => getData(reference, 0)
    .then(oldNumber => {
        const newAmount = +oldNumber - amount
        if (newAmount <= 0) setData(reference, null)
        else setData(reference, newAmount)
        return newAmount
    })


/**
 * Removes a data from the database by a reference
 * @param {String} reference Reference to the database
 * @returns {Promise<any>}
 * 
 * @example
 * Manager.methods.removeData('users/messages/someID')
 */
const removeData = reference => database.ref(reference).set(null)

module.exports = {
    getData,
    setData,
    pushData,
    incrementDataValue,
    decrementDataValue,
    removeData
}