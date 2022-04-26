<template>
    <article>
        <h3>SoldierId: {{ soldierId }}</h3>
        <h3>Soldier Name: {{soldierName}}</h3>
        <h3>Bloodtype: {{Bloodtype}}</h3>
        <h3>Height: {{Height}}</h3>
    </article>
</template>

<script>
export default {
    props: {
        soldierId : Number,
        soldierName : String,
        Bloodtype : String,
        Height : String
    }
}
</script>