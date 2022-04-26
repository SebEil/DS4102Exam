<template>
    <article>
        <h2>Soldiers in the troop</h2>
        <h3>SoldierId: {{ soldierId }}</h3>
        <h3>Soldier Name: {{ soldierName }}</h3>
        <h3>Bloodtype: {{ bloodtype }}</h3>
        <h3>Height: {{ height }}</h3>
        <img :src="`https://localhost:7203/images/${image}`">
        <h3>Deployed: {{ isOnMission }} </h3>
    </article>
</template>

<script>
export default {
    props: {
        soldierId : Number,
        soldierName : String,
        bloodtype : String,
        height : Number,
        image: String,
        isOnMission: Boolean
    }
}
</script>