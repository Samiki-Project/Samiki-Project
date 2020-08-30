const { Client } = require('discord-rpc')
const TimeInvoked = Date.now();
const values = require('../src/Activity.json')

/**
 * Function to Generate the Activity by an Json Object
 * @param {Client} client 
 * @param {JSON} values
 */
module.exports = async (
    client,
    {
        Refresh,
        RefreshTime,
        MainValues: {
            details,
            state,
            image,
            imageTXT,
            limage,
            limageTXT
        },
        RefreshValues: {
            Rdetails,
            Rstate,
            Rimage,
            RimageTXT,
            Rlimage,
            RlimageTXT
        }
    } = values) => {

    await client.setActivity({
        startTimestamp: TimeInvoked,
        details: details,
        state: state,
        largeImageKey: image,
        largeImageText: imageTXT,
        smallImageKey: limage,
        smallImageText: limageTXT
    })
        .then(() => {
            console.log("RichEmbed Set!")
            if (Refresh) {
                let n = 0;
                setInterval(() => {
                    client.setActivity({
                        startTimestamp: TimeInvoked,
                        details: Rdetails,
                        state: Rstate,
                        largeImageKey: Rimage,
                        largeImageText: RimageTXT,
                        smallImageKey: Rlimage,
                        smallImageText: RlimageTXT
                    })
                    console.log(`Refreshed: ${++n} times`)
                }, RefreshTime * 1000);
            }
        })
}