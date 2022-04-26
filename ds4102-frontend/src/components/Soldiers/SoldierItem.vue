<template>
    <section class="soldierContainer">
        <h3>SoldierId: {{ soldierId }}</h3>
        <h3>Soldier Name: {{ soldierName }}</h3>
        <h3>Bloodtype: {{ bloodtype }}</h3>
        <h3>Height: {{ height }}</h3>
        <img :src="`https://localhost:7203/images/${image}`">
        <h3>Deployed: {{ isOnMission }} </h3>
    </section>
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

<style scoped>

    section{ border: 1px solid black;}

    .soldierContainer {
        border-radius: 25px;
        margin: 0.5rem;
        
        min-width: 400px;
        max-width: 500px;
        padding: 3rem;
    }

</style>