<template>
    <article class="weaponContainer">
        <h3>Weapon Id: {{ weaponId }}</h3>
        <h3>WeaponName: {{ weaponName }}</h3>
        <h3>WeaponCost: {{ weaponCost }}</h3>
        <h3>inUse: {{ inUse }}</h3>
    </article>
</template>

<script>
export default {
    props: {
        weaponId : Number,
        weaponName : String,
        weaponCost : Number,
        inUse : Boolean
    }
}
</script>

<style scoped>

    article{ border: 1px solid black;}

    .weaponContainer {
        border-radius: 25px;
        margin: 0.5rem;
        
        min-width: 400px;
        max-width: 500px;
        padding: 3rem;
    }

</style>