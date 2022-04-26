<template>
    <article>
        <h3>SoldierId: {{ SoldierId }}</h3>
        <h3>Soldier Name: {{ SoldierName }}</h3>
        <h3>Bloodtype: {{ Bloodtype }}</h3>
        <h3>Height: {{ Height }}</h3>
        <img :src="`https://localhost:7203/images/${image}`">
        <h3>Deployed: {{ IsOnMission }} </h3>
    </article>
</template>

<script>
export default {
    props: {
        SoldierId : Number,
        SoldierName : String,
        Bloodtype : String,
        Height : Number,
        image: String,
        IsOnMission: Boolean
    }
}
</script>